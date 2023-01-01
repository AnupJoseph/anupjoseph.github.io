<h1>Simple Responsive Vertical Timeline Layout</h1>
<div class="timeline">
  <h2 class="timeline__item timeline__item--year">1985</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Born</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2003</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Graduated High School</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2004</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Started at Fox Valley Technical College (FVTC) in an Electrical Engineering program</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2006</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Changed at FVTC to Web Design & Development program</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2007</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Web Design Internship</h3>
    <p class="timeline__blurb">started internship at company 1.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2008</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">IT Internship</h3>
    <p class="timeline__blurb">Started internship at company 2</p>
  </div>

  <div class="timeline__item">
    <h3 class="timeline__title">Got Married</h3>
  </div>

  <div class="timeline__item">
    <h3 class="timeline__title">Application Engineer</h3>
    <p class="timeline__blurb">Started web design/dev job at company 2.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2012</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">First Child</h3>
    <p class="timeline__blurb">Spouse and I welcomed our first daughter.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2015</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Second Child</h3>
    <p class="timeline__blurb">Spouse and I welcomed our second daughter.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2016</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Lead Application Engineer</h3>
    <p class="timeline__blurb">Promotion to mid-level role.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2018</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Aerial/Circus Arts</h3>
    <p class="timeline__blurb">Started taking classes to learn aerial silks, hoop, and hammock.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2019</h2>
</div>

<style>
  $color: skyblue;
  $lineColor: hotpink;
  $fontColor: #bbb;
  $bgColor1: #222;
  $bgColor2: #444;
  $yearBgColor: #333;

  $breakpoint: 700px;

  * {
    box-sizing: border-box;
  }

  body {
    background-image: linear-gradient(to bottom, $bgColor1, $bgColor2);
    color: $fontColor;
    padding: 1rem;
    font-family: 'Playfair Display', serif;
  }

  h1 {
    text-align: center;
    font-family: 'Raleway', sans-serif;
  }

  .timeline {
    position: relative;
    padding: 1rem;
    margin: 0 auto;
    max-width: 1300px;

    &:before {
      content: '';
      position: absolute;
      height: 100%;
      border: 1px solid $lineColor;
      right: 40px;
      top: 0;
    }

    &:after {
      content: '';
      display: table;
      clear: both;
    }

    @media screen and (min-width: $breakpoint) {
      padding: 2rem;
      &:before {
        left: calc(50% - 1px);
        right: auto;
      }
    }
  }

  .timeline__item {
    padding: 1rem;
    border: 2px solid $lineColor;
    border-image: linear-gradient(to right, $color 0%, $lineColor 100%);
    border-image-slice: 1;
    position: relative;
    margin: 1rem 3rem 1rem 1rem;
    clear: both;

    &:after,
    &:before {
      content: '';
      position: absolute;
    }

    &:before {
      right: -10px;
      top: calc(50% - 5px);
      border-style: solid;
      border-color: $lineColor $lineColor transparent transparent;
      border-width: 10px;
      transform: rotate(45deg);
    }

    @media screen and (min-width: $breakpoint) {
      width: 44%;
      margin: 1rem;

      &:nth-of-type(2n) {
        float: right;
        margin: 1rem;
        border-image: linear-gradient(to right, $lineColor 0%, $color 100%);
        border-image-slice: 1;

        &:before {
          right: auto;
          left: -10px;
          border-color: transparent transparent $lineColor $lineColor;
        }
      }
    }
  }

  .timeline__item--year {
    text-align: center;
    max-width: 150px;
    margin: 0 48px 0 auto;
    font-size: 1.8rem;
    background-color: $yearBgColor;
    line-height: 1;
    border-image: none;
    padding: 0.5rem 1rem 1rem;

    &:before {
      display: none;
    }

    @media screen and (min-width: $breakpoint) {
      text-align: center;
      margin: 0 auto;

      &:nth-of-type(2n) {
        float: none;
        margin: 0 auto;
        border-image: none;

        &:before {
          display: none;
        }
      }
    }
  }

  .timeline__title {
    margin: 0;
    font-family: 'Raleway', sans-serif;
    font-size: 1.5em;
  }

  .timeline__blurb {
    line-height: 1.5;
    font-size: 1rem;
    margin: 0.5rem 0 0;
  }
</style>
