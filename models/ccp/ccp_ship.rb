class CCPShip < ActiveRecord::Base
  self.table_name = "dbo.invTypes"

  def self.get_all
    # Load all of the Ships that reside within the previously loaded ShipTypes
    obj_ship_types = ShipType.all
    ship_types = obj_ship_types.collect do |ship_type|
      ship_type.eve_id
    end

    self.where(:groupID => ship_types)
  end

  def to_rails_model
    Ship.create(
      :eve_id => self.typeID,
      :ship_type_id => self.groupID,
      :name => self.typeName,
      :graphic_id => self.graphicID,
      :radius => self.radius,
      :mass => self.mass,
      :volume => self.volume,
      :capacity => self.capacity,
      :portion_size => self.portionSize,
      :race_id => self.raceID,
      :base_price => self.basePrice,
      :market_group_id => self.marketGroupID,
      :chance_of_duplicating => self.chanceOfDuplicating,
      :icon_id => self.iconID,
      :published => self.published,
    )
  end
end
