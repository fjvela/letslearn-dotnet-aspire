﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api;

public record Zone(string Key, string Name, string State);

public record Forecast(string Name, string DetailedForecast);