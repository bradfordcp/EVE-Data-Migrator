class InvTypeReaction < ActiveRecord::Base
  self.table_name = :invTypeReactions

  attr_accessible :reactionTypeID, :input, :typeID, :quantity
end
