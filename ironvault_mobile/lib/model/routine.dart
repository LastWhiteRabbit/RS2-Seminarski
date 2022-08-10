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

  factory Routine.fromJson(Map<String, dynamic> json) =>
      _$RoutineFromJson(json);

  Map<String, dynamic> toJson() => _$RoutineToJson(this);
}
