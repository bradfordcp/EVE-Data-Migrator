#! /usr/bin/env ruby

require 'pp'
require 'active_record'

# Load all models
Dir.glob(File.join(File.dirname(__FILE__), "models", "*.rb")) do |model|
  require "./models/#{File.basename(model, '.rb')}"
end

# Create the database connections connecting to both mssql and mysql
ccp_connection_info = {
  :adapter  => "sqlserver",
  :host     => "10.0.1.9",
  :username => "eve",
  :database => "Crucible15"
}
rails_connection_info = {
  :adapter  => "mysql2",
  :host     => "localhost",
  :username => "root",
  :database => "killboard_development"
}

to_convert = []
# to_convert << AgtAgent
# to_convert << AgtAgentType
# to_convert << AgtResearchAgent
# to_convert << ChrAncestry
# to_convert << ChrAttribute
# to_convert << ChrBloodline
# to_convert << ChrFaction
# to_convert << ChrRace
# to_convert << CrpActivity
# to_convert << CrpNPCCorporation
# to_convert << CrpNPCCorporationDivision
# to_convert << CrpNPCCorporationResearchField
# to_convert << CrpNPCCorporationTrade
# to_convert << CrpNPCDivision
# to_convert << CrtCategory
# to_convert << CrtCertificate
# to_convert << CrtClass
# to_convert << CrtRecommendation
# to_convert << CrtRelationship
# to_convert << DgmAttributeCategory
# to_convert << DgmAttributeType
# to_convert << DgmEffect
# to_convert << DgmTypeAttribute
# to_convert << DgmTypeEffect
# to_convert << EveGraphic
# to_convert << EveIcon
# to_convert << EveUnit
# to_convert << PlanetSchematic
# to_convert << PlanetSchematicsPinMap
# to_convert << PlanetSchematicsTypeMap
# to_convert << WarCombatZone
# to_convert << WarCombatZoneSystem
# to_convert << InvBlueprintType
# to_convert << InvCategory
# to_convert << InvContrabandType
# to_convert << InvControlTowerResource
# to_convert << InvControlTowerResourcePurpose
# to_convert << InvFlag
# to_convert << InvGroup
# to_convert << InvItem
# to_convert << InvMarketGroup
# to_convert << InvMetaGroup
# to_convert << InvMetaType
# to_convert << InvName
# to_convert << InvPosition
# to_convert << InvType
# to_convert << InvTypeMaterial
# to_convert << InvTypeReaction
# to_convert << InvUniqueName

to_truncate = to_convert

to_truncate.each do |klass|
  klass.establish_connection(rails_connection_info)
  puts "Truncating #{klass}"
  klass.connection.execute("TRUNCATE #{klass.table_name}")
end

to_convert.each do |klass|
  collection = []

  klass.establish_connection(ccp_connection_info)
  total = klass.all.length
  puts "Reading #{total} #{klass.to_s}"
  pp klass.first.attributes
  klass.all.each do |instance|
    collection << instance.attributes
  end

  klass.establish_connection(rails_connection_info)
  puts "Writing #{collection.length} #{klass.to_s}"
  idx = 0
  collection.each do |attributes|
    instance = klass.new attributes
    instance.save

    put "#{idx} of #{total}" if idx % 1000 == 0

    idx = idx + 1
  end
end
