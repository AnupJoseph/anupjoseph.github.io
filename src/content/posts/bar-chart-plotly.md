---
title: 'Recreating a Bar Chart Design in Python'
description: 'A styled bar chart using plotly'
pubDate: 2021-02-25
author: 'Anup Joseph'
tags: []
---

Recreating a Bar Chart Design in Python
=======================================

![captionless image](https://miro.medium.com/v2/resize:fit:770/format:webp/1*T5v47mcspkYIcfkrLu9GTw.png)

[Reference](https://medium.com/swlh/recreating-a-bar-chart-design-in-python-57c084e9cf06)

by [Anup Joseph](https://medium.com/@anupjoseph?source=post_page---byline--57c084e9cf06---------------------------------------)

A styled bar chart using plotly
-------------------------------





_Credits to_ [_Alenka Gucek_](https://www.linkedin.com/in/alenkagucek/) _for her orginal design_

Recently, the Data visualization Stockholm(DVS) meetup group held their first datavis challenge. The dataset for the challenge was snow depth and temperature data from early 20th century to January 2021. The only design constraint was that the visualization had to be black and white.

![captionless image](https://miro.medium.com/v2/resize:fit:310/format:webp/1*MTReQUAp6a1Pe_RkP6Na1Q.png)![captionless image](https://miro.medium.com/v2/resize:fit:922/format:webp/1*l6dogOdb-zl2kLSB3_MXfw.png)

![captionless image](https://miro.medium.com/v2/resize:fit:922/format:webp/1*yJbTXrCMUSBaRpVVt0-ryw.jpeg)![captionless image](https://miro.medium.com/v2/resize:fit:1080/format:webp/1*Z4z5TROLKSZ3byzMHSjpgQ.png)

The challenge received an amazing variety of great submissions. You can read more about them [here](https://medium.com/data-visualization-stockholm/data-viz-challenge-1-a288142e8006).

All of these designs are frankly magnificent. However one design among these stood out to me for its simplicity and elegance. This design was made by [Alenka Gucek](https://twitter.com/alenka_gucek), a postdoc researcher at Uppsala university

![Alenka Gucek’s design](https://miro.medium.com/v2/resize:fit:1400/format:webp/1*T5v47mcspkYIcfkrLu9GTw.png)

I felt that the most important part of this design is its focus on minimalism and its reusability. This design and its variations in color can be used in a variety of places, essentially wherever bar charts are used. It conveys the information accurately and is interesting and visually pleasing at the same time. Keeping this in mind, I decided to recreate this design as closely as possible. I have tried to make this chart as “templatey” as possible.

The original design was done in the far fortresses of Excel, Orgin and CorelDraw. I had little to zero knowledge of these tools and so I decided to recreate this plot in Python using the Plotly library.

![captionless image](https://miro.medium.com/v2/resize:fit:668/format:webp/1*89kz3z25BEL0cmglQjOuMA.png)![captionless image](https://miro.medium.com/v2/resize:fit:668/format:webp/1*Mz3q0MtfE2SKpiesx2W3dA.png)![Great charts with plotly](https://miro.medium.com/v2/resize:fit:668/format:webp/1*TNdMIPTV700lRVrVIq3E8Q.png)

Now the de facto library for creating visualizations with python is matplotlib. However, I personally find matplotlib a bit unrewarding and kind of overwhelming, so I prefer to use plotly. It has built in interactivity and the overall visual as well as developer experience is great. While not as powerful as matplotlib, its quite good and its almost too easy to get started.

Here the link to the google colaboratory interactive Jupyter environment and this is the link to the [github repo](https://github.com/AnupJoseph/plotly_bar_chart).

[Google Colaboratory
-------------------

colab.research.google.com](https://colab.research.google.com/drive/1_DcUOargym-RBgLQfXN0NjXOOCrJa_mT?usp=sharing&source=post_page-----57c084e9cf06---------------------------------------)

To get started lets import the python data science essential libraries, numpy and pandas.

I have also added the datetime libraries and of course, plotly itself.

The dataset for the challenge can be found in [this repository](https://github.com/Dataviz-Stockholm/challenges). Lets import the data and have a look at it. Since by looking at the data on github we already know that the dataset has a time column, I am adding a parse_dates arguement.

Running a unique check we find that there are some bad values in the dataset which need to be cleaned up.

Now admittedly since we are interested in the maximum value of the Snow depth the deviations like “-00.02.00” won’t matter much and simply dropping them won’t cause a lot of trouble. But that’s not really a good practice.

Next, let’s convert the “Snow” column into floats. Since we are interested in the yearly maximum snow depth lets group the dataset in years and find out the maximum snow depth in each year.

This is the data we need to plot. Now plotly has a system of traces for plotting. Each individual trace is a small component like a [scatter of points](https://plotly.com/python/line-and-scatter/) or a [bar](https://plotly.com/python/bar-charts/). These components are collectively available under plotly.[graph_objects](https://plotly.com/python/graph-objects/) and can be combined to create interactive and useful charts.

My first plan was to use bar charts to make this visualization, specifically the go.Bar class and somehow make the adjacent lines of the bar chart disappear. I quickly realized that this was a terrible plan and plotly doesn’t even allow this to be done. My second idea was to create a scatterplot and join them using lines. This is kind of counter-intuitive and takes a second to wrap your head around it. Imagine it like this,

*   A scatterplot has collection of points representing datapoints.
*   Now instead of having points, turn each point into small line with a small length.
*   Seperate each point by the given length.
*   Then join them all together vertically to give an impression of bars.

Now to make any scatterplot we need two dimensions x and y. We will build y co-ordinates first and then create the corresponding x co-ordinates.

Since, this is a scatterplot pretending to be a bar chart we need to have two values of each maximum snow depth (Remember the dots getting width thing I rattled off before?). Next we use these y co-ordinates to build our x co-ordinates. I have chosen a width of 5 for each bars but feel free to choose any other.

Finally our long setup process it done. Lets get started on plotting. We will add one trace of scatterplots with our x and y co-ordinates and set the mode to lines. Plotly will then join each co-ordinate for us. Keeping the in the black and white theme of the challenge lets make the line white and the background dark.

![basic plot](https://miro.medium.com/v2/resize:fit:1400/format:webp/1*QqqzJCxuNFADXJb8TLUCzw.png)

This is what our plot looks like at the moment. We are already quite a long way there. For now lets add a title to the plot and remove the grid and axes.

![captionless image](https://miro.medium.com/v2/resize:fit:1400/format:webp/1*30vtTDphGiU1WmK3yVyh7A.png)

The last additions to our plots are the xaxis and yaxis labels. Here plotly’s interactive components come into play.

*   Choose the years you want to annotate.
*   Find the snow_depth at those years. The snow_max variable will help in this.
*   Hover over the graph and find out the snow_depth of your chosen years. Note the corresponding xaxis values in the tooltip.
*   Pass these xaxis values to your tickvals variable

![captionless image](https://miro.medium.com/v2/resize:fit:1400/format:webp/1*aTE2NeGwmwQPVO7B3mgyUA.png)

We need to fix up the tooltip in the graph. At the moment it shows the actual X and Y axis values of the graph on the tooltip. To change that we need to create a array of values we want to display. For every even index in the x_axis let’s add the corresponding years twice.

The last things left on the plot are annotations. I am deliberately not annotating everything in the plot. However I’ll add an example here.

Here’s the final interactive version of the plot.

So that’s all for today. Hope you had as much fun reading the tutorial as I had writing it.

Thanks to [Samuel Davis](https://medium.com/@sam99dave) and [Darlene Nazerath](https://www.linkedin.com/in/darlene-nazareth-b08bb9192/) for helping with reviewing the the article and testing the code.
Feel free to connect with me on [LinkedIn](https://www.linkedin.com/in/anup-joseph/).