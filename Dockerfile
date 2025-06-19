FROM mcr.microsoft.com/dotnet/framework/wpf:4.8
COPY . /app
WORKDIR /app
RUN msbuild TodoApp.sln
CMD ["TodoApp.exe"]
