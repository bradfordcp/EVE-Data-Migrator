class CrpActivity < ActiveRecord::Base
  self.table_name = :crpActivities
  self.primary_key = :activityID
  
  attr_accessible :activityID, :activityName, :description
end
