class CCPCertificateCategory < ActiveRecord::Base
  self.table_name = "dbo.crtCategories"

  def to_rails_model
    CertificateCategory.create(
      :eve_id => self.categoryID,
      :name => self.categoryName,
      :description => self.description
    )
  end
end