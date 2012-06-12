class RamActivity < ActiveRecord::Base
  self.table_name = :ramActivities
  self.primary_key = :activityID

  attr_accessible :activityID, :activityName, :iconNo, :description, :published
end
