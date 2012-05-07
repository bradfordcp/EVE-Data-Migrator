class DgmEffect < ActiveRecord::Base
  self.table_name = :dgmEffects
  self.primary_key = :effectID

  attr_accessible :effectID, :effectName, :effectCategory, :preExpression, :postExpression, :description, :guid, :iconID, :isPffensive, :isAssistance, :durationAttributeID, :trackingSpeedAttributeID, :dischargeAttributeID, :rangeAttributeID, :falloffAttributeID, :disallowAutoRepeat, :published, :displayName, :isWarpSafe, :rangeChance, :electronicChance, :propulsionChance, :distribution, :sfxName, :npcUsageChanceAttributeID, :npcActivationChanceAttributeID, :fittingUsageChanceAttributeID
end
