﻿using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS2Seminarski.WinUI.Properties;
using RS2Seminarski.Model;
using System.Text.Json;

namespace RS2Seminarski.WinUI.Services
{
    public class StatsAPI
    {
        private string _resource = null;
        public string _endpoint = Settings.Default.ApiURL;

        public StatsAPI(string resourceName = "stats")
        {
            _resource = resourceName;
        }

        public async Task<List<ChartResponse>> GetExercisesPerType()
        {
            try
            {
                var query = "";
                var list = await $"{_endpoint}{_resource}/exercise-exercisetype".SetQueryParams(query).WithBasicAuth(APIService.Username, APIService.Password).GetJsonAsync<List<ChartResponse>>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<Dictionary<string, dynamic>>();

                var errors = errorResponse.First(x => x.Key == "errors");

                string errorsJsonString = String.Join(",", errors.Value);

                Dictionary<string, string[]> errorsMap = JsonSerializer.Deserialize<Dictionary<string, string[]>>(errorsJsonString);

                var stringBuilder = new StringBuilder();
                foreach (var error in errorsMap)
                {
                    stringBuilder.AppendLine($"{error.Key}:\n{string.Join("\n", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(List<ChartResponse>);
            }

        }

        public async Task<List<ChartResponse>> GetExercisesPerLevel()
        {
            try
            {
                var query = "";
                var list = await $"{_endpoint}{_resource}/exercise-exerciselevel".SetQueryParams(query).WithBasicAuth(APIService.Username, APIService.Password).GetJsonAsync<List<ChartResponse>>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<Dictionary<string, dynamic>>();

                var errors = errorResponse.First(x => x.Key == "errors");

                string errorsJsonString = String.Join(",", errors.Value);

                Dictionary<string, string[]> errorsMap = JsonSerializer.Deserialize<Dictionary<string, string[]>>(errorsJsonString);

                var stringBuilder = new StringBuilder();
                foreach (var error in errorsMap)
                {
                    stringBuilder.AppendLine($"{error.Key}:\n{string.Join("\n", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(List<ChartResponse>);
            }
        }

        public async Task<List<ChartResponse>> GetExercisesPerMuscle()
        {
            try
            {
                var query = "";
                var list = await $"{_endpoint}{_resource}/exercise-exercisemuscle".SetQueryParams(query).WithBasicAuth(APIService.Username, APIService.Password).GetJsonAsync<List<ChartResponse>>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<Dictionary<string, dynamic>>();

                var errors = errorResponse.First(x => x.Key == "errors");

                string errorsJsonString = String.Join(",", errors.Value);

                Dictionary<string, string[]> errorsMap = JsonSerializer.Deserialize<Dictionary<string, string[]>>(errorsJsonString);

                var stringBuilder = new StringBuilder();
                foreach (var error in errorsMap)
                {
                    stringBuilder.AppendLine($"{error.Key}:\n{string.Join("\n", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(List<ChartResponse>);
            }
        }
    }
}
