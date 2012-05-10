class TrnTranslationColumn < ActiveRecord::Base
  self.table_name = :trnTranslationColumns
  self.primary_key = :tcID

  attr_accessible :tcGroupID, :tcID, :tableName, :columnName, :masterID
end
