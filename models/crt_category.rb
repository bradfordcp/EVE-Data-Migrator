class CrtCategory < ActiveRecord::Base
  self.table_name = :crtCategories
  self.primary_key = :categoryID

  attr_accessible :categoryID, :description, :categoryName
end
