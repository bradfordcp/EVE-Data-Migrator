class CrtClass < ActiveRecord::Base
  self.table_name = :crtClasses
  self.primary_key = :classID

  attr_accessible :classID, :description, :className
end
