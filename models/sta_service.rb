class StaService < ActiveRecord::Base
  self.table_name = :staServices
  self.primary_key = :serviceID

  attr_accessible :serviceID, :serviceName, :description
end
