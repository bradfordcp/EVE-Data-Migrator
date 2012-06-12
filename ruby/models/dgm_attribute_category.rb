class DgmAttributeCategory < ActiveRecord::Base
  self.table_name = :dgmAttributeCategories
  self.primary_key = :categoryID

  attr_accessible :categoryID, :categoryName, :categoryDescription
end
