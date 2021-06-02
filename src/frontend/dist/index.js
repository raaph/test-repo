var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
class ForecastService {
    fetchAllForecasts() {
        return __awaiter(this, void 0, void 0, function* () {
            return window
                .fetch("https://localhost:44306/WeatherForecast", {
                method: "GET",
            })
                .then((response) => {
                if (response.ok) {
                    return response.json();
                }
                else {
                    return [];
                }
            });
        });
    }
}
function fillTable(forecasts) {
    let rows = "";
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
window.onload = () => __awaiter(this, void 0, void 0, function* () {
    const forecastService = new ForecastService();
    let forecasts = yield forecastService.fetchAllForecasts();
    fillTable(forecasts);
});
