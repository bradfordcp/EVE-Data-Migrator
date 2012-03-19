class CCPShipType < ActiveRecord::Base
  default_scope :conditions => {:categoryID => 6}

  self.table_name = "dbo.invGroups"

  def to_rails_model
    ShipType.create(
      :eve_id => self.groupID,
      :name => self.groupName,
      :icon_id => self.iconID,
      :use_base_price => self.useBasePrice,
      :allow_manufacture => self.allowManufacture,
      :allow_recycler => self.allowRecycler,
      :published => self.published,
    )
  end
end
