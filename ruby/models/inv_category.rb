class InvCategory < ActiveRecord::Base
  self.table_name = :invCategories
  self.primary_key = :categoryID

  attr_accessible :categoryID, :categoryName, :description, :iconID, :published
end
