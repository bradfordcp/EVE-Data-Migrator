class CCPCertificate < ActiveRecord::Base
  self.table_name = "dbo.crtCertificates"

  def to_rails_model
    Certificate.create(
      :id => self.certificateID,
      :category_id => self.categoryID,
      :class_id => self.classID,
      :grade => self.grade,
      :corp_id => self.corpID,
      :icon_id => self.iconID,
      :description => self.description,
    )
  end
end