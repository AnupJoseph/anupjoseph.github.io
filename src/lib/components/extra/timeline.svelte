<h1>Me</h1>
<div class="timeline">
  <h2 class="timeline__item timeline__item--year">2000</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Born</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2015</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Graduated Middle School</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2017</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Started at Fr Conceicao Rodrigues College of Engineering in Computer Engineering</h3>
  </div>

  <h2 class="timeline__item timeline__item--year">2020</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">AI internship</h3>
    <p class="timeline__blurb">started internship at Olcademy.</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2020</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Junior ML Engineer</h3>
    <p class="timeline__blurb">started internship at Omdena</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2020</h2>

  <div class="timeline__item">
    <h3 class="timeline__title">Data Analytics Intern</h3>
    <p class="timeline__blurb">Started internship at WRI</p>
  </div>

  <h2 class="timeline__item timeline__item--year">2021</h2>
  <div class="timeline__item">
    <h3 class="timeline__title">ML Engineer</h3>
    <p class="timeline__blurb">Started ML engineering job at Quantiphi</p>
  </div>
  <h2 class="timeline__item timeline__item--year">2023</h2>
</div>

<style lang="scss">
  /* skyblue: skyblue; */
  /* hotpink: hotpink; */
  /* $fontColor: #bbb; */
  /* $bgColor1: #222; */
  /* $bgColor2: #444; */
  /* $yearBgColor: #333; */

  /* $breakpoint: 700px; */

  * {
    box-sizing: border-box;
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
      border: 1px solid hotpink;
      right: 40px;
      top: 0;
    }

    &:after {
      content: '';
      display: table;
      clear: both;
    }

    @media screen and (min-width: 700px) {
      padding: 2rem;
      &:before {
        left: calc(50% - 1px);
        right: auto;
      }
    }
  }

  .timeline__item {
    padding: 1rem;
    border: 2px solid hotpink;
    border-image: linear-gradient(to right, skyblue 0%, hotpink 100%);
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
      border-color: hotpink hotpink transparent transparent;
      border-width: 10px;
      transform: rotate(45deg);
    }

    @media screen and (min-width: 700px) {
      width: 44%;
      margin: 1rem;

      &:nth-of-type(2n) {
        float: right;
        margin: 1rem;
        border-image: linear-gradient(to right, hotpink 0%, skyblue 100%);
        border-image-slice: 1;

        &:before {
          right: auto;
          left: -10px;
          border-color: transparent transparent hotpink hotpink;
        }
      }
    }
  }

  .timeline__item--year {
    text-align: center;
    max-width: 150px;
    margin: 0 48px 0 auto;
    font-size: 1.8rem;
    background-color: #333;
    line-height: 1;
    border-image: none;
    padding: 0.5rem 1rem 1rem;

    &:before {
      display: none;
    }

    @media screen and (min-width: 700px) {
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
