class InvControlTowerResourcePurpose < ActiveRecord::Base
  self.table_name = :invControlTowerResourcePurposes
  self.primary_key = :purpose

  attr_accessible :purpose, :purposeText
end
