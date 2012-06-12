class InvBlueprintType < ActiveRecord::Base
  self.table_name = :invBlueprintTypes
  self.primary_key = :blueprintTypeID

  attr_accessible :blueprintTypeID, :parentBlueprintTypeID, :productTypeID, :productionTime, :techLevel, :researchProductivityTime, :researchMaterialTime, :researchCopyTime, :productivityModifier, :materialModifier, :wasteFactor, :maxProductionLimit
end
