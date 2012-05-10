class TrnTranslation < ActiveRecord::Base
  self.table_name = :trnTranslations

  attr_accessible :tcID, :keyID, :languageID, :text
end
