import 'dart:convert';
import 'dart:io';

import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';
import 'package:ironvault_mobile/model/exercise.dart';

class ExerciseProvider with ChangeNotifier {
  HttpClient client = new HttpClient();
  IOClient? http;
  ExerciseProvider() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<Exercise>> get(dynamic searchObject) async {
    var url = Uri.parse("https://10.0.2.2:7113/api/Exercise");

    String username = "admin";
    String password = "admin";

    String basicAuth =
        "Basic ${base64Encode(utf8.encode('$username:$password'))}";

    var headers = {
      "Content-Type": "application/json",
      "Authorization": basicAuth
    };

    var response = await http!.get(url, headers: headers);

    if (response.statusCode < 400) {
      var data = jsonDecode(response.body);
      List<Exercise> list =
          data.map((x) => Exercise.fromJson(x)).cast<Exercise>().toList();
      return list;
    } else {
      throw Exception("User not allowed");
    }
  }
}
