class InvContrabandType < ActiveRecord::Base
  self.table_name = :invContrabandTypes

  attr_accessible :factionID, :typeID, :standingLoss, :confiscateMinSec, :fineByValue, :attackMinSec
end
