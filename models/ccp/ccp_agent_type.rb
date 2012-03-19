class CCPAgentType < ActiveRecord::Base

  self.table_name = "dbo.agtAgentTypes"

  def to_rails_model
    AgentType.create(
      :eve_id => self.agentTypeID,
      :name => self.agentType
    )
  end
end
