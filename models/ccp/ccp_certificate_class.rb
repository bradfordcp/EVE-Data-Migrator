class CCPCertificateClass < ActiveRecord::Base
  self.table_name = "dbo.crtClasses"

  def to_rails_model
    CertificateClass.create(
      :id => self.classID,
      :name => self.className,
      :description => self.description,
    )
  end
end