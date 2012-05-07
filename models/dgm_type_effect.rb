class DgmTypeEffect < ActiveRecord::Base
  self.table_name = :dgmTypeEffects

  attr_accessible :typeID, :effectID, :isDefault
end
