interface Forecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

class ForecastService {
  public async fetchAllForecasts(): Promise<Forecast[]> {
    return window
      .fetch("https://localhost:44306/WeatherForecast", {
        method: "GET",
      })
      .then((response) => {
        if (response.ok) {
          return response.json();
        } else {
          return [] as Forecast[];
        }
      });
  }
}

function fillTable(forecasts: Forecast[]) {
  let rows: string = "";
  forecasts.forEach((forecast, i) => {
    rows += `
    <tr>
      <td>${new Date(forecast.date).toLocaleDateString("de-CH")}</td>
      <td>${forecast.temperatureC}</td>
      <td>${forecast.temperatureF}</td>
      <td>${forecast.summary}</td>
    </tr>
    `;
  });
  let table = document.getElementById("data-table");
  table.innerHTML += rows;
}

window.onload = async () => {
  const forecastService = new ForecastService();
  let forecasts = await forecastService.fetchAllForecasts();
  fillTable(forecasts);
};
