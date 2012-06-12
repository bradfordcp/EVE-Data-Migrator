class RamInstallationTypeContent < ActiveRecord::Base
  self.table_name = :ramInstallationTypeContents

  attr_accessible :installationTypeID, :assemblyLineTypeID, :quantity
end
