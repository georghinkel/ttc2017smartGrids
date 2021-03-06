/**
 */
package substationStandard.Dataclasses;

import org.eclipse.emf.ecore.EObject;

import substationStandard.Enumerations.DPStatusKind;

/**
 * <!-- begin-user-doc -->
 * A representation of the model object '<em><b>DP Status</b></em>'.
 * <!-- end-user-doc -->
 *
 * <p>
 * The following features are supported:
 * </p>
 * <ul>
 *   <li>{@link substationStandard.Dataclasses.DPStatus#getVal <em>Val</em>}</li>
 * </ul>
 *
 * @see substationStandard.Dataclasses.DataclassesPackage#getDPStatus()
 * @model
 * @generated
 */
public interface DPStatus extends EObject {
	/**
	 * Returns the value of the '<em><b>Val</b></em>' attribute.
	 * The literals are from the enumeration {@link substationStandard.Enumerations.DPStatusKind}.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the '<em>Val</em>' attribute isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the '<em>Val</em>' attribute.
	 * @see substationStandard.Enumerations.DPStatusKind
	 * @see #setVal(DPStatusKind)
	 * @see substationStandard.Dataclasses.DataclassesPackage#getDPStatus_Val()
	 * @model
	 * @generated
	 */
	DPStatusKind getVal();

	/**
	 * Sets the value of the '{@link substationStandard.Dataclasses.DPStatus#getVal <em>Val</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the '<em>Val</em>' attribute.
	 * @see substationStandard.Enumerations.DPStatusKind
	 * @see #getVal()
	 * @generated
	 */
	void setVal(DPStatusKind value);

} // DPStatus
