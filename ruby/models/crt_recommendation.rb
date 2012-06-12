class CrtRecommendation < ActiveRecord::Base
  self.table_name = :crtRecommendations
  self.primary_key = :recommendationID

  attr_accessible :recommendationID, :shipTypeID, :certificateID, :recommendationLevel
end
