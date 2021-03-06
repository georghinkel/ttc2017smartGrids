/**
 */
package gluemodel.CIM.IEC61968.Metering;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

import org.eclipse.emf.common.util.Enumerator;

/**
 * <!-- begin-user-doc -->
 * A representation of the literals of the enumeration '<em><b>Demand Kind</b></em>',
 * and utility methods for working with them.
 * <!-- end-user-doc -->
 * @see gluemodel.CIM.IEC61968.Metering.MeteringPackage#getDemandKind()
 * @model
 * @generated
 */
public enum DemandKind implements Enumerator {
	/**
	 * The '<em><b>Rolling Block</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #ROLLING_BLOCK_VALUE
	 * @generated
	 * @ordered
	 */
	ROLLING_BLOCK(0, "rollingBlock", "rollingBlock"),

	/**
	 * The '<em><b>Logarithmic</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #LOGARITHMIC_VALUE
	 * @generated
	 * @ordered
	 */
	LOGARITHMIC(1, "logarithmic", "logarithmic"),

	/**
	 * The '<em><b>Fixed Block</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #FIXED_BLOCK_VALUE
	 * @generated
	 * @ordered
	 */
	FIXED_BLOCK(2, "fixedBlock", "fixedBlock");

	/**
	 * The '<em><b>Rolling Block</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Rolling Block</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #ROLLING_BLOCK
	 * @model name="rollingBlock"
	 * @generated
	 * @ordered
	 */
	public static final int ROLLING_BLOCK_VALUE = 0;

	/**
	 * The '<em><b>Logarithmic</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Logarithmic</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #LOGARITHMIC
	 * @model name="logarithmic"
	 * @generated
	 * @ordered
	 */
	public static final int LOGARITHMIC_VALUE = 1;

	/**
	 * The '<em><b>Fixed Block</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Fixed Block</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #FIXED_BLOCK
	 * @model name="fixedBlock"
	 * @generated
	 * @ordered
	 */
	public static final int FIXED_BLOCK_VALUE = 2;

	/**
	 * An array of all the '<em><b>Demand Kind</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private static final DemandKind[] VALUES_ARRAY =
		new DemandKind[] {
			ROLLING_BLOCK,
			LOGARITHMIC,
			FIXED_BLOCK,
		};

	/**
	 * A public read-only list of all the '<em><b>Demand Kind</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public static final List<DemandKind> VALUES = Collections.unmodifiableList(Arrays.asList(VALUES_ARRAY));

	/**
	 * Returns the '<em><b>Demand Kind</b></em>' literal with the specified literal value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param literal the literal.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static DemandKind get(String literal) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			DemandKind result = VALUES_ARRAY[i];
			if (result.toString().equals(literal)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Demand Kind</b></em>' literal with the specified name.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param name the name.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static DemandKind getByName(String name) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			DemandKind result = VALUES_ARRAY[i];
			if (result.getName().equals(name)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Demand Kind</b></em>' literal with the specified integer value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the integer value.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static DemandKind get(int value) {
		switch (value) {
			case ROLLING_BLOCK_VALUE: return ROLLING_BLOCK;
			case LOGARITHMIC_VALUE: return LOGARITHMIC;
			case FIXED_BLOCK_VALUE: return FIXED_BLOCK;
		}
		return null;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final int value;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String name;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String literal;

	/**
	 * Only this class can construct instances.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private DemandKind(int value, String name, String literal) {
		this.value = value;
		this.name = name;
		this.literal = literal;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public int getValue() {
	  return value;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getName() {
	  return name;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getLiteral() {
	  return literal;
	}

	/**
	 * Returns the literal value of the enumerator, which is its string representation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public String toString() {
		return literal;
	}
	
} //DemandKind
