# Load all rails models
Dir.glob(File.join(File.dirname(__FILE__), "rails", "*.rb")) do |model|
  require "#{File.dirname(model)}/#{File.basename(model, '.rb')}"
end
