# Load all CCP models
Dir.glob(File.join(File.dirname(__FILE__), "ccp", "*.rb")) do |model|
  require "#{File.dirname(model)}/#{File.basename(model, '.rb')}"
end
