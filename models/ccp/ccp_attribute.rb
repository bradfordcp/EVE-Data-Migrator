class CCPAttribute < ActiveRecord::Base
  self.table_name = "chrAttributes"

  def to_rails_model
    CharacterAttribute.create(
      :id => self.attributeID,
      :name => self.attributeName,
      :description => self.description,
      :short_description => self.shortDescription,
      :icon_id => self.iconID,
      :notes => self.notes
    )
  end

end
