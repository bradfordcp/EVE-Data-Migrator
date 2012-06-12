class CrtCertificate < ActiveRecord::Base
  self.table_name = :crtCertificates
  self.primary_key = :certificateID

  attr_accessible :certificateID, :categoryID, :classID, :grade, :corpID, :iconID, :description
end
