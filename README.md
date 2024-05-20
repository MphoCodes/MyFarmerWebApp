
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agri-Energy Connect</title>
    <link rel="stylesheet" href="styles.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">
    <style>
        /* GENERAL STYLING */
        body {
            background-image: url('https://source.unsplash.com/1600x900/?farm');
            background-size: cover;
            background-position: center;
            color: lawngreen;
            text-align: center;
            font-family: 'Roboto', sans-serif;
            margin: 0;
            line-height: 1.6;

        }

        a {
            text-decoration: none;
            color: #4CAF50;
        }

        h1, h2, h3 {
            font-weight: 900;
        }

        /* HERO SECTION */
        .hero {
            background-image: url('https://source.unsplash.com/1600x900/?farm');
            background-size: cover;
            background-position: center;
            color: lawngreen;
            text-align: center;
            padding: 100px 20px;
        }

            .hero h1 {
                font-size: 3em;
                margin-bottom: 10px;
            }

            .hero p {
                font-size: 1.3em;
                margin-bottom: 30px;
            }

        .explore-button, .sign-up-button {
            background-color: #4CAF50;
            color:  black;
            padding: 15px 30px;
            border: none;
            border-radius: 5px;
            font-weight: bold;
            transition: background-color 0.3s ease;
        }

        .explore-button, .sign-up-button {
            border: 2px solid #F5F5F5;
        }

            .explore-button:hover, .sign-up-button:hover {
                background-color: #e0a800;
                cursor: pointer;
            }

        /* FEATURES SECTION */
        .features {
            display: flex;
            justify-content: space-around;
            flex-wrap: wrap;
            gap: 20px;
        }

        .feature-card {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 20px;
            text-align: center;
            flex: 1 1 calc(25% - 20px);
            max-width: calc(25% - 20px);
        }

            .feature-card i {
                color: #28a745; /* Adjust color as needed */
                margin-bottom: 10px;
            }

            .feature-card h2 {
                font-size: 1.5rem;
                margin-bottom: 10px;
            }

            .feature-card p {
                font-size: 1rem;
                color: #555;
            }

        /* TESTIMONIALS SECTION */
        .testimonials {
            text-align: center;
            padding: 40px 20px;
            background-color: #f8f9fa;
        }

            .testimonials h2 {
                margin-bottom: 20px;
                font-size: 2rem;
            }

        .testimonial-card {
            display: inline-block;
            background: white;
            padding: 20px;
            margin: 10px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1), 0 0 15px rgba(40, 167, 69, 0.6);
            width: 300px;
            height: 350px;
            vertical-align: top;
            transition: box-shadow 0.3s ease-in-out;
        }

            .testimonial-card:hover {
                box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1), 0 0 25px rgba(40, 167, 69, 0.8);
            }

            .testimonial-card img {
                border-radius: 50%;
                width: 80px;
                height: 80px;
                object-fit: cover;
                margin-bottom: 10px;
            }

            .testimonial-card p {
                font-size: 1rem;
                color: #333;
                height: calc(100% - 110px); /* Adjust to fit the remaining height */
                display: flex;
                align-items: center;
                justify-content: center;
                text-align: center;
                padding: 0 10px;
                box-sizing: border-box;
            }
        /* CALL TO ACTION */
        .call-to-action {
            background-color: #4CAF50;
            color: white;
            padding: 50px 20px;
            text-align: center;
        }

        /* FOOTER */
        footer {
            background-color: #333;
            color: white;
            padding: 20px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .social-media a {
            margin-left: 15px;
        }

        .privacy-policy a {
            color: white;
            margin-left: 15px;
        }
    </style>
</head>
<body>

    <main>
        <section class="hero">
            <h1>Empowering Sustainable Agriculture through Green Energy Solutions</h1>
            <p>Join the Agri-Energy Connect community to innovate, collaborate, and thrive</p>
            <button class="explore-button">Explore the Platform</button>
            <button class="sign-up-button">Sign Up for Free</button>
        </section>

        <section class="features">
            <div class="feature-card">
                <i class="fas fa-seedling fa-3x"></i>
                <h2>Sustainable Farming Hub</h2>
                <p>A resource centre for sharing best practices in sustainable farming</p>
            </div>

            <div class="feature-card">
                <i class="fas fa-solar-panel fa-3x"></i>
                <h2>Green Energy Marketplace</h2>
                <p>A marketplace for green energy solutions tailored to agricultural needs</p>
            </div>

            <div class="feature-card">
                <i class="fas fa-chalkboard-teacher fa-3x"></i>
                <h2>Educational Resources</h2>
                <p>Online courses, webinars, and workshops on integrating green energy technologies in agriculture</p>
            </div>

            <div class="feature-card">
                <i class="fas fa-handshake fa-3x"></i>
                <h2>Project Collaboration</h2>
                <p>A platform for farmers and energy experts to propose and collaborate on joint projects</p>
            </div>
        </section>

        <section class="testimonials">
            <h2>What our users say</h2>
            <div class="testimonial-card">
                <img src="https://media.licdn.com/dms/image/D4D03AQHYSGtq8VOslQ/profile-displayphoto-shrink_200_200/0/1710094803991?e=1721865600&v=beta&t=kaKbrBvNWFDOpBShwNfCRVN8RPzX9lkBxpx_H7DpqG0" alt="User 1 Avatar">
                <p>"Agri-Energy Connect has helped me reduce my carbon footprint and increase my crop yields. I couldn't be happier!" - Mpho, Farmer</p>
            </div>
            <div class="testimonial-card">
                <img src="https://media.licdn.com/dms/image/D5603AQHhjtgvN6VKHQ/profile-displayphoto-shrink_200_200/0/1713450059841?e=1721865600&v=beta&t=5HSiyxN-Y4OynJZ8kBr3lIgptNiSmLFwKJUKjx4Bzbs" alt="User 2 Avatar">
                <p>"I've learned so much from the educational resources on Agri-Energy Connect. It's a game-changer for sustainable agriculture!" - Lucian, Soil scientist</p>
            </div>
        </section>

        <section class="call-to-action">
            <h2>Join the movement towards sustainable agriculture and green energy</h2>
            <button class="sign-up-button">Sign Up for Free</button>
            <button class="explore-button">Explore the Platform</button>
        </section>
    </main>

 
</body>
</html>