class TranslationTable < ActiveRecord::Base
  self.table_name = :translationTables

  attr_accessible :sourceTable, :destinationTable, :translatedKey, :tcGroupID, :tcID
end
