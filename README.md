<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agri-Energy Connect Prototype</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            color: #333;
        }
        .container {
            width: 80%;
            margin: auto;
            overflow: hidden;
        }
        header {
            background: #50b3a2;
            color: #fff;
            padding-top: 30px;
            min-height: 70px;
            border-bottom: #3e8e7e 3px solid;
        }
        header a, footer a {
            color: #fff;
            text-decoration: none;
            text-transform: uppercase;
            font-size: 16px;
        }
        header ul {
            padding: 0;
            list-style: none;
        }
        header li {
            float: right;
            display: inline;
            padding: 0 20px 0 20px;
        }
        header #branding {
            float: left;
        }
        header #branding h1 {
            margin: 0;
        }
        .button {
            height: 38px;
            background: #50b3a2;
            border: none;
            padding-left: 20px;
            padding-right: 20px;
            color: #fff;
            transition: opacity 0.3s ease;
        }
        .button:hover {
            opacity: 0.8;
        }
        section {
            padding: 20px;
            margin: 20px 0;
            background: #fff;
        }
        footer {
            background: #3e8e7e;
            color: #fff;
            text-align: center;
            padding: 20px;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <header>
        <div class="container">
            <div id="branding">
                <h1>Agri-Energy Connect Prototype</h1>
            </div>
            <nav>
                <ul>
                    <li><a href="#setup">Setup</a></li>
                    <li><a href="#build">Build</a></li>
                    <li><a href="#roles">User Roles</a></li>
                    <li><a href="#faq">FAQ</a></li>
                </ul>
            </nav>
        </div>
    </header>

    <section id="intro" class="container">
        <h2>Welcome to Agri-Energy Connect!</h2>
        <p>This prototype is designed to showcase the functionality of our ASP.Net site for connecting agricultural producers with renewable energy resources. This page will guide you through setting up the development environment, building and running the prototype, and understanding its functionalities and user roles.</p>
    </section>

    <section id="download" class="container">
        <h2>Downloading the Prototype</h2>
        <p>You can download the Agri-Energy Connect prototype from our GitHub repository: <a href="https://github.com/VCWVL/prog7311---programming-3a---part-2-MphoNdlela16">Agri-Energy Connect Repository</a>.</p>
    </section>

    <section id="setup" class="container">
        <h2>Setting Up Development Environment</h2>
        <ol>
            <li><strong>Clone the Repository:</strong> Clone the Agri-Energy Connect repository to your local machine using Git, or download it as a ZIP file from the repository page.</li>
            <li><strong>Install Dependencies:</strong> Ensure you have all the necessary dependencies installed. This project primarily uses .NET framework, ASP.NET, and SQL Server. Make sure you have Visual Studio installed for ease of development.</li>
            <li><strong>Database Setup:</strong> You need to set up the database for the project. Run the SQL scripts provided in the <code>database_scripts</code> folder to create the necessary tables and populate initial data.</li>
            <li><strong>Configuration:</strong> Update the connection string in the <code>web.config</code> file to point to your local SQL Server instance.</li>
        </ol>
    </section>

    <section id="build" class="container">
        <h2>Building and Running the Prototype</h2>
        <ol>
            <li><strong>Open Solution:</strong> Open the solution file (<code>AgriEnergyConnect.sln</code>) in Visual Studio.</li>
            <li><strong>Build Solution:</strong> Build the solution to ensure all dependencies are resolved and the project compiles without errors.</li>
            <li><strong>Run the Application:</strong> Start the application by pressing the "Start" button in Visual Studio. This will launch the ASP.Net site on your local host.</li>
            <li><strong>Accessing the Site:</strong> Open your web browser and navigate to <code>http://localhost:&lt;port_number&gt;</code> where <code>&lt;port_number&gt;</code> is the port specified in your Visual Studio environment settings.</li>
        </ol>
    </section>

    <section id="roles" class="container">
        <h2>System Functionalities and User Roles</h2>
        <h3>Producer</h3>
        <ul>
            <li>Create and manage their profiles.</li>
            <li>List their available resources such as land, water, and crops.</li>
            <li>Search for renewable energy resources and connect with energy providers.</li>
            <li>View analytics and insights related to their resources and energy consumption.</li>
        </ul>
        <h3>Energy Provider</h3>
        <ul>
            <li>Create and manage their profiles.</li>
            <li>List their available energy solutions such as solar panels, wind turbines, etc.</li>
            <li>Search for agricultural producers interested in renewable energy solutions and connect with them.</li>
            <li>View analytics and insights related to energy usage patterns and potential clients.</li>
        </ul>
        <h3>Administrator</h3>
        <ul>
            <li>User management: creating, editing, and deleting user accounts.</li>
            <li>Content management: moderating listings, reviews, and other user-generated content.</li>
            <li>Analytics: viewing overall platform usage statistics and trends.</li>
        </ul>
        <h3>Farmer</h3>
        <ul>
            <li>Create and manage their profiles.</li>
            <li>List their available resources.</li>
        </ul>
        <h3>Employee</h3>
        <ul>
            <li>User management: creating, editing, and deleting user accounts.</li>
            <li>Content management: moderating listings, reviews, and other user-generated content.</li>
        </ul>
    </section>

    <section id="faq" class="container">
        <h2>Frequently Asked Questions (FAQ)</h2>
        <p><strong>Q: What is Agri-Energy Connect?</strong><br>
        A: Agri-Energy Connect is a prototype designed to facilitate the connection between agricultural producers and renewable energy resources. It aims to streamline the process of accessing renewable energy solutions for agricultural operations.</p>
        <p><strong>Q: Who can use Agri-Energy Connect?</strong><br>
        A: Agri-Energy Connect caters to two main user roles: producers and energy providers. Agricultural producers can list their resources and connect with energy providers, while renewable energy providers can showcase their solutions and connect with agricultural producers.</p>
        <p><strong>Q: How do I set up the development environment for Agri-Energy Connect?</strong><br>
        A: Refer to the "Setting Up Development Environment" section in the README for detailed instructions on cloning the repository, installing dependencies, setting up the database, and configuring the environment.</p>
        <p><strong>Q: What functionalities does Agri-Energy Connect offer?</strong><br>
        A: Agri-Energy Connect enables producers to manage their profiles, list resources, search for renewable energy solutions, and view analytics. Energy providers can manage profiles, list solutions, search for producers, and access analytics. Administrators have additional privileges for user and content management, as well as analytics.</p>
        <p><strong>Q: How do I access the Agri-Energy Connect prototype after setting it up?</strong><br>
        A: Once the development environment is set up, open the solution file in Visual Studio, build the solution, and start the application. Then, access the prototype by navigating to <code>http://localhost:&lt;port_number&gt;</code> in your web browser, where <code>&lt;port_number&gt;</code> is the specified port.</p>
        <p><strong>Q: Where can I get support or report issues with Agri-Energy Connect?</strong><br>
        A: If you encounter any issues or have questions, feel free to reach out to the development team for assistance. Contact information can typically be found in the project's repository or documentation.</p>
        <p><strong>Q: Are there default login credentials for testing purposes?</strong><br>
        A: Yes, default login credentials are provided for testing:</p>
        <ul>
            <li><strong>Employee:</strong><br>
                Email: employee@employee.com<br>
                Password: Admin1234#</li>
            <li><strong>Farmer:</strong><br>
                Email: john@doefarming.com<br>
                Password: Farmer1234#</li>
        </ul>
    </section>

    <footer>
        <p>Code Attribution:</p>
        <p>W3Schools free online web tutorials (no date) W3Schools Online Web Tutorials. Available at: <a href="https://www.w3schools.com/">https://www.w3schools.com/</a> (Accessed: 22 May 2024).</p>
        <p>Where developers learn, share, & build careers (no date) Stack Overflow. Available at: <a href="https://stackoverflow.com/">https://stackoverflow.com/</a> (Accessed:22 May 2024).</p>
        <p>Thank you for your interest in Agri-Energy Connect!</p>
    </footer>
</body>
</html>
