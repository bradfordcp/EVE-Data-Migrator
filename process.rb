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

to_truncate = [AgentType, Race, Bloodline, CharacterAttribute, Ancestry, CertificateClass, 
               CertificateCategory, Certificate, ShipType, Ship]
to_convert = [CCPAgentType, CCPAttribute, CCPRace, CCPBloodline, CCPAncestry, CCPCertificateClass, 
              CCPCertificateCategory, CCPCertificate, CCPShipType, CCPShip]
helper = [CCPName]

# Fire up all db connections
to_truncate.each do |klass|
  klass.establish_connection(rails_connection_info)
end
to_convert.each do |klass|
  klass.establish_connection(ccp_connection_info)
end
helper.each do |klass|
  klass.establish_connection(ccp_connection_info)
end

# Truncate all existing tables that we are working with
to_truncate.each do |klass|
  puts "Truncating #{klass}"
  klass.connection.execute("TRUNCATE #{klass.table_name}")
end

puts ""
puts "##########################################################"
puts ""

# Convert the CCP models into Rails models
to_convert.each do |klass|
  puts "Process #{klass.to_s}"
  puts "########################################"
  instances = []
  if klass.respond_to? "get_all"
    instances = klass.get_all
  else
    instances = klass.all
  end

  instances.each do |instance|
    rm = instance.to_rails_model
    puts rm.id
  end

  puts ""
end
