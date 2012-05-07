class AgtResearchAgent < ActiveRecord::Base
  self.table_name = :agtResearchAgents
  
  attr_accessible :agentID, :typeID
end
