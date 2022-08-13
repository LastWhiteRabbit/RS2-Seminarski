import 'package:json_annotation/json_annotation.dart';
part 'user_insert_request.g.dart';

@JsonSerializable()
class UserInsertRequest {
  String? name;
  String? surname;
  String? email;
  String? mobile;
  String? userName;
  String? password;
  String? passwordConfirmation;
  List<String>? roleIdList;

  UserInsertRequest();

  factory UserInsertRequest.fromJson(Map<String, dynamic> json) =>
      _$UserInsertRequestFromJson(json);

  /// Connect the generated [_$UserInsertRequestToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$UserInsertRequestToJson(this);
}
