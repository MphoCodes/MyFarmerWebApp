[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/0uJxXwfG)


# Agri-Energy Connect Prototype

Welcome to Agri-Energy Connect! This prototype is designed to showcase the functionality of our ASP.Net site for connecting agricultural producers with renewable energy resources. This README will guide you through setting up the development environment, building and running the prototype, and understanding its functionalities and user roles.

## Downloading the Prototype

You can download the Agri-Energy Connect prototype from our GitHub repository: [Agri-Energy Connect Repository](https://github.com/VCWVL/prog7311---programming-3a---part-2-MphoNdlela16)

## Setting Up Development Environment

To set up the development environment, follow these steps:

1. **Clone the Repository**: Clone the Agri-Energy Connect repository to your local machine using Git, or download it as a ZIP file from the repository page.

2. **Install Dependencies**: Ensure you have all the necessary dependencies installed. This project primarily uses .NET framework, ASP.NET, and SQL Server. Make sure you have Visual Studio installed for ease of development.

3. **Database Setup**: You need to set up the database for the project. Run the SQL scripts provided in the `database_scripts` folder to create the necessary tables and populate initial data.

4. **Configuration**: Update the connection string in the `web.config` file to point to your local SQL Server instance.

## Building and Running the Prototype

Once you have set up the development environment, follow these steps to build and run the prototype:

1. **Open Solution**: Open the solution file (`AgriEnergyConnect.sln`) in Visual Studio.

2. **Build Solution**: Build the solution to ensure all dependencies are resolved and the project compiles without errors.

3. **Run the Application**: Start the application by pressing the "Start" button in Visual Studio. This will launch the ASP.Net site on your local host.

4. **Accessing the Site**: Open your web browser and navigate to `http://localhost:<port_number>` where `<port_number>` is the port specified in your Visual Studio environment settings.

## System Functionalities and User Roles

Agri-Energy Connect offers the following functionalities and user roles:

1. **Producer**: Agricultural producers can:
   - Create and manage their profiles.
   - List their available resources such as land, water, and crops.
   - Search for renewable energy resources and connect with energy providers.
   - View analytics and insights related to their resources and energy consumption.

2. **Energy Provider**: Renewable energy providers can:
   - Create and manage their profiles.
   - List their available energy solutions such as solar panels, wind turbines, etc.
   - Search for agricultural producers interested in renewable energy solutions and connect with them.
   - View analytics and insights related to energy usage patterns and potential clients.

3. **Administrator**: Administrators have access to administrative functionalities such as:
   - User management: creating, editing, and deleting user accounts.
   - Content management: moderating listings, reviews, and other user-generated content.
   - Analytics: viewing overall platform usage statistics and trends.

## Conclusion

With these instructions, you should be able to set up, build, and run the Agri-Energy Connect prototype on your local environment. If you encounter any issues or have any questions, feel free to reach out to our development team for assistance. Thank you for your interest in Agri-Energy Connect!