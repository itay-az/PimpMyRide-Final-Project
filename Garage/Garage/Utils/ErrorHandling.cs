using Garage.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Utils
{
    internal class ErrorHandling
    {
        public static async Task HandleErrorResponse(HttpResponseMessage response)
        {
            string content = await response.Content.ReadAsStringAsync();

            try
            {
                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(content);

                MessageBox.Show($"Error: {errorResponse.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (JsonException)
            {
                MessageBox.Show("Invalid response format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
