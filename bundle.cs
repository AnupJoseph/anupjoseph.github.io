html, body {
    height: 100%;
}

.flex-container-row {
    padding: 0;
    margin: 0;
    height: 100%;
    width: 100%;

    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    align-items: center;
    align-content: center;
    justify-content: space-around;
  }

  .flex-container-column {
    padding: 0;
    margin: 0;
    height: 100%;
    width: 100%;

    display: flex;
    flex-direction: column;
    flex-wrap: wrap;
    align-items: center;
    align-content: center;
    justify-content: space-around;
  }
  
  .flex-item-intro {
    /* background: pink; */
    width: 40%;
    height: 40%;

    color: black;
    font-family: 'Cutive Mono', monospace;
    font-size: 1.5em;
    text-align: left;
  }

  .flex-item {
    /* background: pink; */
    width: 40%;
    height: 90%;

    color: black;
    font-family: 'Cutive Mono', monospace;
    font-size: 1.5em;
    text-align: left;
  }

  img {
      height: 100%;
      float: right;
  }