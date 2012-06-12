class AgtAgentType < ActiveRecord::Base
  self.table_name = :agtAgentTypes
  self.primary_key = :agentTypeID

  has_many :agents, :foreign_key => :agentTypeID

  attr_accessible :agentTypeID, :agentType
end
