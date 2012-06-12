class TrnTranslationLanguage < ActiveRecord::Base
  self.table_name = :trnTranslationLanguages
  self.primary_key = :numericLanguageID

  attr_accessible :numericLanguageID, :languageID, :languageName
end
