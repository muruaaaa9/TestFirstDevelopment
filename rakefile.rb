require 'rubygems'
require 'albacore'

task:default => [:compile, :test]

desc "Complile the solution"
msbuild :compile do |msb|
  msb.properties :configuration => :Debug
  msb.targets :Build
  msb.solution = "TestFirstDevelopment.sln"
end

desc "Run tests"
nunit :test do |nunit|
	nunit.command = "packages/NUnit.Runners.2.6.2/tools/nunit-console.exe"
	nunit.assemblies "src/Domain.Tests/bin/Debug/Domain.Tests.dll"
end
