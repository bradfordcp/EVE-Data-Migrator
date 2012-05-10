class RamTypeRequirement < ActiveRecord::Base
  self.table_name = :ramTypeRequirements

  attr_accessible :typeID, :activityID, :requiredTypeID, :quantity, :damagePerJob, :recycle
end
