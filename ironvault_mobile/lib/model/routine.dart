import 'dart:convert';

import 'package:json_annotation/json_annotation.dart';

part 'routine.g.dart';

@JsonSerializable()
class Routine {
  int? routineId;
  String? routineName;
  String? description;
  String? exerciseNames;

  Routine() {}
}