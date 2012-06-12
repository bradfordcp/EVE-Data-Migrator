class AgtAgent < ActiveRecord::Base
  self.table_name = :agtAgents
  self.primary_key = :agentID

  belongs_to :agent_type, :foreign_key => :agentTypeID

  attr_accessible :agentID, :divisionID, :corporationID, :locationID, :level, :quantity, :agentTypeID, :isLocator
end
