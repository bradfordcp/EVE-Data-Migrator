class InvTypeMaterial < ActiveRecord::Base
  self.table_name = :invTypeMaterials

  attr_accessible :typeID, :materialTypeId, :quantity
end
