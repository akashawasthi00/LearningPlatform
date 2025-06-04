# Use the ASP.NET 4.8 base image (compatible with 4.7)
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019

# Set the working directory inside the container
WORKDIR /inetpub/wwwroot

# Copy the entire solution directory to the container
COPY . /app

# Restore NuGet packages and build the solution using MSBuild
RUN msbuild /app/MySolution.sln /p:Configuration=Release /p:DeployOnBuild=true /p:PublishProfile=Default /p:PublishDir=/inetpub/wwwroot /maxcpucount

# Expose port 80 for IIS
EXPOSE 80

# Configure IIS to run the application
RUN powershell -NoProfile -Command \
    Remove-WebSite -Name 'Default Web Site'; \
    New-WebSite -Name 'MyApp' -Port 80 -PhysicalPath 'C:\inetpub\wwwroot' -Force

# Ensure IIS service starts
ENTRYPOINT ["C:\\ServiceMonitor.exe", "w3svc"]