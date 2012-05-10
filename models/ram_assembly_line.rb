class RamAssemblyLine < ActiveRecord::Base
  self.table_name = :ramAssemblyLines
  self.primary_key = :assemblyLineID

  attr_accessible :assemblyLineID, :assemblyLineTypeID, :contrainerID, :nextFreeTime, :UIGroupingID, :costInstall, :costPerHour, :restrictionMask, :discountPerGoodStandingPoint, :surchargePerBadStandingPoint, :minimumStanding, :minimumCharSecurity, :minimumCorpSecurity, :maximumCharSecurity, :maximumCorpSecurity, :ownerID, :activityID
end
