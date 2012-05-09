class InvGroup < ActiveRecord::Base
  self.table_name = :invGroups
  self.primary_key = :groupID

  attr_accessible :groupID, :categoryID, :groupName, :description, :iconID, :useBasePrice, :allowManufacture, :allowRecycler, :anchored, :anchorable, :fittableNonSingleton, :published
end
