class StaOperationService < ActiveRecord::Base
  self.table_name = :staOperationServices

  attr_accessible :operationID, :serviceID
end
