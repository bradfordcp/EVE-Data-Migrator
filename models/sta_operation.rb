class StaOperation < ActiveRecord::Base
  self.table_name = :staOperations
  self.primary_key = :operationID

  attr_accessible :activityID, :operationID, :operationName, :description, :fringe, :corridor, :hub, :border, :ratio, :caldariStationTypeID, :minmatarStationTypeID, :amarrStationTypeID, :gallenteStationTypeID, :joveStationTypeID
end
