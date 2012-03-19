class CCPAgent < ActiveRecord::Base
  self.table_name = "dbo.agtAgents"

  def to_rails_model
    # The name of the agent is stored in a different table, let's grab that and store the data together
    name = CCPName.where(:itemID => self.agentID).first

    Agent.create(
      :eve_id => self.agentID,
      :name => name.itemName,
      :division_id => self.divisionID,
      :corporation_id => self.corporationID,
      :location_id => self.locationID,
      :level => self.level,
      :quality => self.quality,
      :agent_type_id => self.agentTypeID,
      :is_locator => self.isLocator
    )
  end
end
