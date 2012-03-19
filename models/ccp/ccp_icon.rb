class CCPIcon < ActiveRecord::Base
  self.table_name = "dbo.eveIcons"

  def to_rails_model
    Icon.create(
      :eve_id => self.iconID,
      :file => self.iconFile,
      :description => self.description,
    )
  end
end